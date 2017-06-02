S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 25060
Date: 2017-05-31 13:07:28+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25060, uid 5000)

Register Information
r0   = 0xbeac0090, r1   = 0x03600002
r2   = 0x03600002, r3   = 0xbeac0090
r4   = 0xb27b6ced, r5   = 0xb7d87f20
r6   = 0xb7cc3240, r7   = 0xbeabffd8
r8   = 0x8005e0f2, r9   = 0xb5eba708
r10  = 0xb7cc0618, fp   = 0x00000000
ip   = 0xb27d59b8, sp   = 0xbeabffb0
lr   = 0xb27a00a7, pc   = 0xb27a00e2
cpsr = 0x80070030

Memory Information
MemTotal:   987012 KB
MemFree:     74540 KB
Buffers:     74548 KB
Cached:     270648 KB
VmPeak:     134464 KB
VmSize:     133144 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27932 KB
VmRSS:       27220 KB
VmData:      45276 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 25060 TID = 25060
25060 25061 25316 25317 25326 

Maps Information
af1ec000 af9eb000 rw-p [stack:25326]
b1351000 b1359000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b136b000 b1b6a000 rw-p [stack:25317]
b1b6a000 b1b6b000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b7b000 b1b8f000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1ba3000 b1ba4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bb4000 b1bb7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bc8000 b1bc9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bd9000 b1bdb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1beb000 b1bed000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bfd000 b1c0d000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c1d000 b1c29000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c3b000 b243a000 rw-p [stack:25316]
b276b000 b2772000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2785000 b278b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b279b000 b27c5000 r-xp /opt/usr/apps/org.example.client/bin/client
b291e000 b2a01000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a38000 b2a60000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a72000 b3271000 rw-p [stack:25061]
b3271000 b3273000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3283000 b328d000 r-xp /lib/libnss_files-2.20-2014.11.so
b329e000 b32a7000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32b8000 b32c9000 r-xp /lib/libnsl-2.20-2014.11.so
b32dc000 b32e2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32f3000 b32f4000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b331c000 b3323000 r-xp /usr/lib/libminizip.so.1.0.0
b3333000 b3338000 r-xp /usr/lib/libstorage.so.0.1
b3348000 b33a7000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33bd000 b33d1000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e1000 b3425000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3435000 b343d000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b344d000 b347d000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3490000 b3549000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b355d000 b35b0000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c1000 b35dc000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ec000 b36ad000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c0000 b36d0000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e0000 b36ed000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36fe000 b3705000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3715000 b3756000 r-xp /usr/lib/libmdm.so.1.2.12
b3766000 b376e000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b377d000 b378d000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ae000 b380e000 r-xp /usr/lib/libasound.so.2.0.0
b3820000 b3823000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3833000 b3836000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3846000 b384b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b385b000 b385c000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b386c000 b3877000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b388b000 b3892000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38a2000 b38a8000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38b8000 b38bd000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38cd000 b38e8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38f8000 b38ff000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b390f000 b3912000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3923000 b3951000 r-xp /usr/lib/libidn.so.11.5.44
b3961000 b3977000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3988000 b3992000 r-xp /usr/lib/libcares.so.2.1.0
b39a2000 b39ac000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39bc000 b39be000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39ce000 b39cf000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39df000 b39e3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39f4000 b3a1c000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a2d000 b3a56000 r-xp /usr/lib/libturbojpeg.so
b3a76000 b3a7c000 r-xp /usr/lib/libgif.so.4.1.6
b3a8c000 b3ad2000 r-xp /usr/lib/libcurl.so.4.3.0
b3ae3000 b3b04000 r-xp /usr/lib/libexif.so.12.3.3
b3b1f000 b3b34000 r-xp /usr/lib/libtts.so
b3b45000 b3b4d000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b5d000 b3c23000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c43000 b3d3b000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d5a000 b3e28000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e3f000 b3e41000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e51000 b3e57000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e67000 b3e8a000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e9b000 b3e9d000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ead000 b3eaf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec0000 b3ec5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3edc000 b3ede000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eee000 b3ef5000 r-xp /usr/lib/libsensord-share.so
b3f05000 b3f1d000 r-xp /usr/lib/libsensor.so.1.1.0
b3f2e000 b3f31000 r-xp /usr/lib/libXv.so.1.0.0
b3f41000 b3f46000 r-xp /usr/lib/libutilX.so.1.1.0
b3f56000 b3f5b000 r-xp /usr/lib/libappcore-common.so.1.1
b3f6b000 b3f72000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f85000 b3f89000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f9a000 b4078000 r-xp /usr/lib/libCOREGL.so.4.0
b4098000 b409b000 r-xp /usr/lib/libuuid.so.1.3.0
b40ab000 b40c2000 r-xp /usr/lib/libblkid.so.1.1.0
b40d3000 b40d5000 r-xp /usr/lib/libXau.so.6.0.0
b40e5000 b412c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b413e000 b4144000 r-xp /usr/lib/libjson-c.so.2.0.1
b4155000 b4159000 r-xp /usr/lib/libogg.so.0.7.1
b4169000 b418b000 r-xp /usr/lib/libvorbis.so.0.4.3
b419b000 b427f000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b429b000 b429e000 r-xp /usr/lib/libEGL.so.1.4
b42af000 b42b5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42c5000 b42c7000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42d7000 b42e4000 r-xp /usr/lib/libGLESv2.so.2.0
b42f5000 b4357000 r-xp /usr/lib/libpixman-1.so.0.28.2
b436c000 b4384000 r-xp /usr/lib/libmount.so.1.1.0
b4396000 b43aa000 r-xp /usr/lib/libxcb.so.1.1.0
b43ba000 b43c1000 r-xp /lib/libcrypt-2.20-2014.11.so
b43f9000 b43fb000 r-xp /usr/lib/libiri.so
b440b000 b4416000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4427000 b445d000 r-xp /usr/lib/libpulse.so.0.16.2
b446e000 b44b1000 r-xp /usr/lib/libsndfile.so.1.0.25
b44c6000 b44db000 r-xp /lib/libexpat.so.1.5.2
b44ed000 b45ab000 r-xp /usr/lib/libcairo.so.2.11200.14
b45bf000 b45c7000 r-xp /usr/lib/libdrm.so.2.4.0
b45d7000 b45da000 r-xp /usr/lib/libdri2.so.0.0.0
b45ea000 b4638000 r-xp /usr/lib/libssl.so.1.0.0
b464d000 b4659000 r-xp /usr/lib/libeeze.so.1.13.0
b466a000 b4673000 r-xp /usr/lib/libethumb.so.1.13.0
b4683000 b4686000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4696000 b484d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5638000 b5641000 r-xp /usr/lib/libXi.so.6.1.0
b5651000 b5653000 r-xp /usr/lib/libXgesture.so.7.0.0
b5663000 b5667000 r-xp /usr/lib/libXtst.so.6.1.0
b5677000 b567d000 r-xp /usr/lib/libXrender.so.1.3.0
b568d000 b5693000 r-xp /usr/lib/libXrandr.so.2.2.0
b56a3000 b56a5000 r-xp /usr/lib/libXinerama.so.1.0.0
b56b6000 b56b9000 r-xp /usr/lib/libXfixes.so.3.1.0
b56c9000 b56d4000 r-xp /usr/lib/libXext.so.6.4.0
b56e4000 b56e6000 r-xp /usr/lib/libXdamage.so.1.1.0
b56f6000 b56f8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5708000 b57ea000 r-xp /usr/lib/libX11.so.6.3.0
b57fe000 b5805000 r-xp /usr/lib/libXcursor.so.1.0.2
b5815000 b582d000 r-xp /usr/lib/libudev.so.1.6.0
b582f000 b5832000 r-xp /lib/libattr.so.1.1.0
b5842000 b5862000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5863000 b5868000 r-xp /usr/lib/libffi.so.6.0.2
b5879000 b5891000 r-xp /lib/libz.so.1.2.8
b58a1000 b58a3000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58b3000 b5988000 r-xp /usr/lib/libxml2.so.2.9.2
b599d000 b5a38000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a54000 b5a57000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a67000 b5a80000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a91000 b5aa2000 r-xp /lib/libresolv-2.20-2014.11.so
b5ab6000 b5b30000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b45000 b5b47000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b57000 b5b5e000 r-xp /usr/lib/libembryo.so.1.13.0
b5b6e000 b5b78000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b89000 b5ba1000 r-xp /usr/lib/libpng12.so.0.50.0
b5bb2000 b5bd5000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bf6000 b5c0a000 r-xp /usr/lib/libector.so.1.13.0
b5c1b000 b5c33000 r-xp /usr/lib/liblua-5.1.so
b5c44000 b5c9b000 r-xp /usr/lib/libfreetype.so.6.11.3
b5caf000 b5cd7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ce8000 b5cfb000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d0c000 b5d46000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d57000 b5d65000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d75000 b5d7d000 r-xp /usr/lib/libtbm.so.1.0.0
b5d8d000 b5d9a000 r-xp /usr/lib/libeio.so.1.13.0
b5daa000 b5dac000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dbc000 b5dc1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd1000 b5de8000 r-xp /usr/lib/libefreet.so.1.13.0
b5dfa000 b5e1a000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e2a000 b5e4a000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e4c000 b5e52000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e62000 b5e73000 r-xp /usr/lib/libemotion.so.1.13.0
b5e84000 b5e8b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e9b000 b5eaa000 r-xp /usr/lib/libeo.so.1.13.0
b5ebb000 b5ecd000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ede000 b5ee3000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ef3000 b5f0c000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f1c000 b5f39000 r-xp /usr/lib/libeet.so.1.13.0
b5f52000 b5f9a000 r-xp /usr/lib/libeina.so.1.13.0
b5fab000 b5fbb000 r-xp /usr/lib/libefl.so.1.13.0
b5fcc000 b60b1000 r-xp /usr/lib/libicuuc.so.51.1
b60ce000 b620e000 r-xp /usr/lib/libicui18n.so.51.1
b6225000 b625d000 r-xp /usr/lib/libecore_x.so.1.13.0
b626f000 b6272000 r-xp /lib/libcap.so.2.21
b6282000 b62ab000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62bc000 b62c3000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62d5000 b630c000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b631d000 b6408000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b641b000 b6494000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64a6000 b64ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64bb000 b64c5000 r-xp /usr/lib/libvconf.so.0.2.45
b64d5000 b64d7000 r-xp /usr/lib/libvasum.so.0.3.1
b64e7000 b64e9000 r-xp /usr/lib/libttrace.so.1.1
b64f9000 b64fc000 r-xp /usr/lib/libiniparser.so.0
b650c000 b6532000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6542000 b6547000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6558000 b656f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6580000 b65eb000 r-xp /lib/libm-2.20-2014.11.so
b65fc000 b6602000 r-xp /lib/librt-2.20-2014.11.so
b6613000 b6620000 r-xp /usr/lib/libunwind.so.8.0.1
b6656000 b677a000 r-xp /lib/libc-2.20-2014.11.so
b678f000 b67a8000 r-xp /lib/libgcc_s-4.9.so.1
b67b8000 b689a000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ab000 b68d5000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68e6000 b6922000 r-xp /usr/lib/libsystemd.so.0.4.0
b6924000 b69a7000 r-xp /usr/lib/libedje.so.1.13.0
b69ba000 b69d8000 r-xp /usr/lib/libecore.so.1.13.0
b69f8000 b6b7f000 r-xp /usr/lib/libevas.so.1.13.0
b6bb4000 b6bc8000 r-xp /lib/libpthread-2.20-2014.11.so
b6bdc000 b6e10000 r-xp /usr/lib/libelementary.so.1.13.0
b6e3f000 b6e43000 r-xp /usr/lib/libsmack.so.1.0.0
b6e53000 b6e5a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e6a000 b6e6c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e7c000 b6e7f000 r-xp /usr/lib/libbundle.so.0.1.22
b6e8f000 b6e91000 r-xp /lib/libdl-2.20-2014.11.so
b6ea2000 b6eba000 r-xp /usr/lib/libaul.so.0.1.0
b6ece000 b6ed3000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ee4000 b6ef1000 r-xp /usr/lib/liblptcp.so
b6f03000 b6f07000 r-xp /usr/lib/libsys-assert.so
b6f18000 b6f38000 r-xp /lib/ld-2.20-2014.11.so
b6f49000 b6f4e000 r-xp /usr/bin/launchpad-loader
b7a84000 b7deb000 rw-p [heap]
beaa0000 beac1000 rw-p [stack]
beaa0000 beac1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25060)
Call Stack Count: 26
 0:  + 0x0 (0xb27a00e2) [/opt/usr/apps/org.example.client/bin/client] + 0x50e2
 1: _ZN8UILayoutC2ERKS_ + 0x1a (0xb27a00a7) [/opt/usr/apps/org.example.client/bin/client] + 0x50a7
 2: _ZN13RecommendView6drawUIEP9Naviframe + 0x1be (0xb27ad1e3) [/opt/usr/apps/org.example.client/bin/client] + 0x121e3
 3: _ZN13RecommendViewC2EP9Naviframe + 0x3a (0xb27acfab) [/opt/usr/apps/org.example.client/bin/client] + 0x11fab
 4: _ZN12RecommendBtn5clickEv + 0x2a (0xb27acf55) [/opt/usr/apps/org.example.client/bin/client] + 0x11f55
 5: _ZN6Button14callback_clickEPvP10_Eo_OpaqueS0_ + 0x24 (0xb27b6d11) [/opt/usr/apps/org.example.client/bin/client] + 0x1bd11
 6: (0xb6a5e7ed) [/usr/lib/libevas.so.1] + 0x667ed
 7: (0xb5ea6219) [/usr/lib/libeo.so.1] + 0xb219
 8: eo_event_callback_call + 0x68 (0xb5ea4fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 9: evas_object_smart_callback_call + 0x38 (0xb6a5fedd) [/usr/lib/libevas.so.1] + 0x67edd
10: (0xb697b167) [/usr/lib/libedje.so.1] + 0x57167
11: (0xb697fd87) [/usr/lib/libedje.so.1] + 0x5bd87
12: (0xb697bb21) [/usr/lib/libedje.so.1] + 0x57b21
13: (0xb697bef1) [/usr/lib/libedje.so.1] + 0x57ef1
14: (0xb697c045) [/usr/lib/libedje.so.1] + 0x58045
15: (0xb69c9d11) [/usr/lib/libecore.so.1] + 0xfd11
16: (0xb69c5c4b) [/usr/lib/libecore.so.1] + 0xbc4b
17: (0xb69cba5d) [/usr/lib/libecore.so.1] + 0x11a5d
18: ecore_main_loop_begin + 0x3e (0xb69cbc83) [/usr/lib/libecore.so.1] + 0x11c83
19: appcore_efl_main + 0x20c (0xb6ed12bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
20: ui_app_main + 0xc0 (0xb3f87909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
21: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27b5957) [/opt/usr/apps/org.example.client/bin/client] + 0x1a957
22: main + 0x40 (0xb279fcd1) [/opt/usr/apps/org.example.client/bin/client] + 0x4cd1
23: (0xb6f4abb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
24: __libc_start_main + 0x114 (0xb666c4bc) [/lib/libc.so.6] + 0x164bc
25: (0xb6f4aeb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.959+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
05-31 13:07:14.969+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
05-31 13:07:14.969+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:14.969+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.140+0900 W/CERT_SVC_VCORE(25204): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
05-31 13:07:15.230+0900 E/rpm-installer(25204): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
05-31 13:07:15.230+0900 E/rpm-installer(25204): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
05-31 13:07:15.290+0900 E/PKGMGR_PARSER(25204): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
05-31 13:07:15.310+0900 I/PRIVACY-MANAGER-CLIENT(25204): SocketClient.cpp: SocketClient(37) > Client created
05-31 13:07:15.310+0900 I/PRIVACY-MANAGER-CLIENT(25204): SocketClient.cpp: connect(62) > Client connected
05-31 13:07:15.310+0900 I/PRIVACY-MANAGER-SERVER(  916): SocketService.cpp: mainloop(230) > Got incoming connection
05-31 13:07:15.310+0900 I/PRIVACY-MANAGER-CLIENT(25204): SocketClient.cpp: disconnect(72) > Client disconnected
05-31 13:07:15.310+0900 E/PKGMGR_CERT(25204): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
05-31 13:07:15.320+0900 E/PKGMGR_CERT(25204): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
05-31 13:07:15.320+0900 E/PKGMGR_CERT(25204): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
05-31 13:07:15.350+0900 E/rpm-installer(25204): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
05-31 13:07:15.360+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
05-31 13:07:15.360+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/ESD     (  894): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.360+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:15.370+0900 W/AUL_AMD (  612): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
05-31 13:07:15.370+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
05-31 13:07:15.370+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
05-31 13:07:15.510+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 13:07:15.510+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 13:07:16.571+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 13:07:17.041+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: sighandler(417) > child NORMAL exit [25204]
05-31 13:07:18.032+0900 E/PKGMGR  (25253): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
05-31 13:07:18.072+0900 E/PKGMGR_SERVER(25201): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
05-31 13:07:18.082+0900 E/PKGMGR_INFO(25201): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
05-31 13:07:18.082+0900 E/rpm-installer(25201): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
05-31 13:07:18.093+0900 E/PKGMGR_SERVER(25201): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
05-31 13:07:18.093+0900 E/PKGMGR  (25253): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[252530002]
05-31 13:07:18.213+0900 E/PKGMGR_INSTALLER(25255): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
05-31 13:07:18.213+0900 E/rpm-installer(25255): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
05-31 13:07:18.233+0900 E/rpm-installer(25255): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
05-31 13:07:18.233+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
05-31 13:07:18.233+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
05-31 13:07:18.233+0900 E/rpm-installer(25255): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
05-31 13:07:18.233+0900 E/rpm-installer(25255): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
05-31 13:07:18.293+0900 W/CERT_SVC_VCORE(25255): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
05-31 13:07:18.343+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
05-31 13:07:18.343+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.343+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [30]
05-31 13:07:18.353+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.363+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.573+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
05-31 13:07:18.623+0900 E/rpm-installer(25255): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
05-31 13:07:18.623+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
05-31 13:07:18.633+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
05-31 13:07:18.663+0900 I/PRIVACY-MANAGER-CLIENT(25255): SocketClient.cpp: SocketClient(37) > Client created
05-31 13:07:18.873+0900 E/PKGMGR_PARSER(25255): pkgmgr_parser.c: __check_theme(142) > theme for installation.
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 5
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 5
05-31 13:07:18.893+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
05-31 13:07:18.903+0900 E/PKGMGR_CERT(25255): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [60]
05-31 13:07:18.903+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.903+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.923+0900 E/rpm-installer(25255): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
05-31 13:07:18.943+0900 E/rpm-installer(25255): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (119) > InstallationInProgress [100]
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:18.943+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.565+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (1894) > PackageEventHandler - req: 12330002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
05-31 13:07:20.775+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (78) > Installation is Completed. [Package = org.example.client]
05-31 13:07:20.775+0900 I/Tizen::App( 1233): (671) > Enter. package(org.example.client), installationResult(0)
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.775+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 13:07:20.785+0900 I/Tizen::App( 1233): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
05-31 13:07:20.805+0900 W/ISF_PANEL_EFL(  794): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
05-31 13:07:20.815+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
05-31 13:07:20.825+0900 I/Tizen::App( 1233): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
05-31 13:07:20.825+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
05-31 13:07:20.825+0900 E/HOME_APPS(  867): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
05-31 13:07:20.825+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
05-31 13:07:20.825+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 13:07:20.845+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (840) > Enter.
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (703) > Exit.
05-31 13:07:20.845+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
05-31 13:07:20.855+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (131) > Enter
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
05-31 13:07:20.855+0900 I/Tizen::App( 1233): (883) > Exit.
05-31 13:07:20.875+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
05-31 13:07:20.905+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: sighandler(417) > child NORMAL exit [25255]
05-31 13:07:22.567+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 13:07:22.567+0900 E/PKGMGR_SERVER(25201): pkgmgr-server.c: main(2471) > package manager server terminated.
05-31 13:07:24.969+0900 W/AUL     (25309): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
05-31 13:07:24.969+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 13:07:24.969+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
05-31 13:07:24.979+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
05-31 13:07:24.979+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
05-31 13:07:24.979+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 25309
05-31 13:07:24.979+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
05-31 13:07:24.989+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 13:07:24.989+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 13:07:24.989+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 13:07:24.989+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 13:07:24.989+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 13:07:25.009+0900 I/abc     (25060): abc
05-31 13:07:25.009+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: ui_app_main(789) > app_efl_main
05-31 13:07:25.009+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 13:07:25.039+0900 E/TBM     (25060): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 13:07:25.089+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 25060, appid: org.example.client
05-31 13:07:25.099+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 13:07:25.109+0900 W/AUL     (25309): launch.c: app_request_to_launchpad(425) > request cmd(0) result(25060)
05-31 13:07:25.109+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
05-31 13:07:25.320+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(514) > [APP 25060] Event: RESET State: CREATED
05-31 13:07:25.320+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 13:07:25.330+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.330+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.340+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.340+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.340+0900 E/EFL     (25060): edje<25060> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 13:07:25.340+0900 E/EFL     (25060): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 13:07:25.350+0900 W/APP_CORE(25060): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3600002
05-31 13:07:25.350+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 13:07:25.350+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:25.350+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:25.370+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 13:07:25.370+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:25.380+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:25.390+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 13:07:25.460+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: PAUSE State: RUNNING
05-31 13:07:25.460+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 13:07:25.460+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(514) > [APP 25060] Event: RESUME State: CREATED
05-31 13:07:25.460+0900 E/cluster-home(  867): homescreen.cpp: OnPause(260) >  app pause
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(4)
05-31 13:07:25.470+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(867)
05-31 13:07:25.470+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: bg
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25060) status(3)
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 13:07:25.470+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 13:07:25.470+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(25060)
05-31 13:07:25.470+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 25060, appid: org.example.client, status: fg
05-31 13:07:25.480+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 13:07:25.480+0900 I/APP_CORE(25060): appcore-efl.c: __do_app(625) > [APP 25060] Initial Launching, call the resume_cb
05-31 13:07:25.480+0900 I/CAPI_APPFW_APPLICATION(25060): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 13:07:25.480+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_pause_cb(304) > widget obj was paused
05-31 13:07:25.480+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(152) > enter background group
05-31 13:07:25.480+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: bg
05-31 13:07:25.820+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(25060) status(0)
05-31 13:07:26.140+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 13:07:26.140+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 25060.
05-31 13:07:26.140+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1487
05-31 13:07:26.821+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766566254
05-31 13:07:26.931+0900 I/UXT     (25323): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 13:07:26.951+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766566386
05-31 13:07:27.221+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766566650
05-31 13:07:27.221+0900 I/MY_LOG  (25060): Button pressed
05-31 13:07:27.312+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766566738
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: vconf_get_bool(2729) > vconf_get_bool(25060) : db/ise/keysound error
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 13:07:27.312+0900 E/VCONF   (25060): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 13:07:27.362+0900 I/MY_LOG  (25060): Button unpressed
05-31 13:07:28.182+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=766567616
05-31 13:07:28.192+0900 I/MY_LOG  (25060): Button pressed
05-31 13:07:28.232+0900 E/EFL     (25060): ecore_x<25060> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=766567660
05-31 13:07:28.232+0900 I/MY_LOG  (25060): Button unpressed
05-31 13:07:28.603+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 13:07:28.613+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 13:07:28.613+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 13:07:28.613+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 13:07:28.623+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 25060 pgid = 25060
05-31 13:07:28.623+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(25060)
05-31 13:07:28.673+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 13:07:28.673+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 13:07:28.673+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 13:07:28.673+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 25060
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[25060] terminate event is forwarded
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 25060, ]
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
05-31 13:07:28.673+0900 I/Tizen::App( 1233): (512) > Not registered pid(25060)
05-31 13:07:28.673+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
05-31 13:07:28.673+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:28.673+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 25060
05-31 13:07:28.673+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 25060
05-31 13:07:28.683+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1491
05-31 13:07:28.683+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 13:07:28.693+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:28.693+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 25060.
05-31 13:07:28.703+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 13:07:28.703+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 13:07:28.703+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 13:07:28.703+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 13:07:28.713+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 13:07:28.733+0900 I/Tizen::System( 1233): (259) > Active app [com.samsun], current [org.exampl] 
05-31 13:07:28.733+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 13:07:28.743+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 13:07:28.753+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
05-31 13:07:28.773+0900 W/CRASH_MANAGER(25329): worker.c: worker_job(1199) > 1125060636c69149620364
