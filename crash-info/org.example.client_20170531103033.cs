S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 14052
Date: 2017-05-31 10:30:33+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 14052, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x80080405
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xb2786345, r5   = 0xb7609330
r6   = 0xb76a7038, r7   = 0xbea501a0
r8   = 0x80080405, r9   = 0xb5e89708
r10  = 0xb7697430, fp   = 0x00000000
ip   = 0x80080405, sp   = 0xbea50188
lr   = 0x00000000, pc   = 0xb2786358
cpsr = 0x600f0030

Memory Information
MemTotal:   987012 KB
MemFree:     81352 KB
Buffers:     73132 KB
Cached:     269696 KB
VmPeak:     126980 KB
VmSize:     125660 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29564 KB
VmRSS:       28476 KB
VmData:      37536 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35840 KB
VmPTE:          98 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 14052 TID = 14052
14052 14055 21202 21220 

Maps Information
af9c1000 b01c0000 rw-p [stack:21220]
b0f3b000 b0f4c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0f5c000 b0f61000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1b1f000 b1b27000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b38000 b1b39000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b49000 b1b5d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b71000 b1b72000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b82000 b1b85000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b96000 b1b97000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1ba7000 b1ba9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bb9000 b1bbb000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bcb000 b1bdb000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1beb000 b1bf7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c09000 b2408000 rw-p [stack:21202]
b2739000 b2740000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2753000 b2759000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2769000 b2794000 r-xp /opt/usr/apps/org.example.client/bin/client
b28ed000 b29d0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a07000 b2a2f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a41000 b3240000 rw-p [stack:14055]
b3240000 b3242000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3252000 b325c000 r-xp /lib/libnss_files-2.20-2014.11.so
b326d000 b3276000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3287000 b3298000 r-xp /lib/libnsl-2.20-2014.11.so
b32ab000 b32b1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32c2000 b32c3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32eb000 b32f2000 r-xp /usr/lib/libminizip.so.1.0.0
b3302000 b3307000 r-xp /usr/lib/libstorage.so.0.1
b3317000 b3376000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b338c000 b33a0000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33b0000 b33f4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3404000 b340c000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b341c000 b344c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b345f000 b3518000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b352c000 b357f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3590000 b35ab000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35bb000 b367c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b368f000 b369f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36af000 b36bc000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36cd000 b36d4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36e4000 b3725000 r-xp /usr/lib/libmdm.so.1.2.12
b3735000 b373d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b374c000 b375c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b377d000 b37dd000 r-xp /usr/lib/libasound.so.2.0.0
b37ef000 b37f2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3802000 b3805000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3815000 b381a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b382a000 b382b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b383b000 b3846000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b385a000 b3861000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3871000 b3877000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3887000 b388c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b389c000 b38b7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38c7000 b38ce000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38de000 b38e1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38f2000 b3920000 r-xp /usr/lib/libidn.so.11.5.44
b3930000 b3946000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3957000 b3961000 r-xp /usr/lib/libcares.so.2.1.0
b3971000 b397b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b398b000 b398d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b399d000 b399e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39ae000 b39b2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39c3000 b39eb000 r-xp /usr/lib/libui-extension.so.0.1.0
b39fc000 b3a25000 r-xp /usr/lib/libturbojpeg.so
b3a45000 b3a4b000 r-xp /usr/lib/libgif.so.4.1.6
b3a5b000 b3aa1000 r-xp /usr/lib/libcurl.so.4.3.0
b3ab2000 b3ad3000 r-xp /usr/lib/libexif.so.12.3.3
b3aee000 b3b03000 r-xp /usr/lib/libtts.so
b3b14000 b3b1c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b2c000 b3bf2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c12000 b3d0a000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d29000 b3df7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e0e000 b3e10000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e20000 b3e26000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e36000 b3e59000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e6a000 b3e6c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e7c000 b3e7e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e8f000 b3e94000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3eab000 b3ead000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ebd000 b3ec4000 r-xp /usr/lib/libsensord-share.so
b3ed4000 b3eec000 r-xp /usr/lib/libsensor.so.1.1.0
b3efd000 b3f00000 r-xp /usr/lib/libXv.so.1.0.0
b3f10000 b3f15000 r-xp /usr/lib/libutilX.so.1.1.0
b3f25000 b3f2a000 r-xp /usr/lib/libappcore-common.so.1.1
b3f3a000 b3f41000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f54000 b3f58000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f69000 b4047000 r-xp /usr/lib/libCOREGL.so.4.0
b4067000 b406a000 r-xp /usr/lib/libuuid.so.1.3.0
b407a000 b4091000 r-xp /usr/lib/libblkid.so.1.1.0
b40a2000 b40a4000 r-xp /usr/lib/libXau.so.6.0.0
b40b4000 b40fb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b410d000 b4113000 r-xp /usr/lib/libjson-c.so.2.0.1
b4124000 b4128000 r-xp /usr/lib/libogg.so.0.7.1
b4138000 b415a000 r-xp /usr/lib/libvorbis.so.0.4.3
b416a000 b424e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b426a000 b426d000 r-xp /usr/lib/libEGL.so.1.4
b427e000 b4284000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4294000 b4296000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42a6000 b42b3000 r-xp /usr/lib/libGLESv2.so.2.0
b42c4000 b4326000 r-xp /usr/lib/libpixman-1.so.0.28.2
b433b000 b4353000 r-xp /usr/lib/libmount.so.1.1.0
b4365000 b4379000 r-xp /usr/lib/libxcb.so.1.1.0
b4389000 b4390000 r-xp /lib/libcrypt-2.20-2014.11.so
b43c8000 b43ca000 r-xp /usr/lib/libiri.so
b43da000 b43e5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43f6000 b442c000 r-xp /usr/lib/libpulse.so.0.16.2
b443d000 b4480000 r-xp /usr/lib/libsndfile.so.1.0.25
b4495000 b44aa000 r-xp /lib/libexpat.so.1.5.2
b44bc000 b457a000 r-xp /usr/lib/libcairo.so.2.11200.14
b458e000 b4596000 r-xp /usr/lib/libdrm.so.2.4.0
b45a6000 b45a9000 r-xp /usr/lib/libdri2.so.0.0.0
b45b9000 b4607000 r-xp /usr/lib/libssl.so.1.0.0
b461c000 b4628000 r-xp /usr/lib/libeeze.so.1.13.0
b4639000 b4642000 r-xp /usr/lib/libethumb.so.1.13.0
b4652000 b4655000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4665000 b481c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5607000 b5610000 r-xp /usr/lib/libXi.so.6.1.0
b5620000 b5622000 r-xp /usr/lib/libXgesture.so.7.0.0
b5632000 b5636000 r-xp /usr/lib/libXtst.so.6.1.0
b5646000 b564c000 r-xp /usr/lib/libXrender.so.1.3.0
b565c000 b5662000 r-xp /usr/lib/libXrandr.so.2.2.0
b5672000 b5674000 r-xp /usr/lib/libXinerama.so.1.0.0
b5685000 b5688000 r-xp /usr/lib/libXfixes.so.3.1.0
b5698000 b56a3000 r-xp /usr/lib/libXext.so.6.4.0
b56b3000 b56b5000 r-xp /usr/lib/libXdamage.so.1.1.0
b56c5000 b56c7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56d7000 b57b9000 r-xp /usr/lib/libX11.so.6.3.0
b57cd000 b57d4000 r-xp /usr/lib/libXcursor.so.1.0.2
b57e4000 b57fc000 r-xp /usr/lib/libudev.so.1.6.0
b57fe000 b5801000 r-xp /lib/libattr.so.1.1.0
b5811000 b5831000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5832000 b5837000 r-xp /usr/lib/libffi.so.6.0.2
b5848000 b5860000 r-xp /lib/libz.so.1.2.8
b5870000 b5872000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5882000 b5957000 r-xp /usr/lib/libxml2.so.2.9.2
b596c000 b5a07000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a23000 b5a26000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a36000 b5a4f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a60000 b5a71000 r-xp /lib/libresolv-2.20-2014.11.so
b5a85000 b5aff000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b14000 b5b16000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b26000 b5b2d000 r-xp /usr/lib/libembryo.so.1.13.0
b5b3d000 b5b47000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b58000 b5b70000 r-xp /usr/lib/libpng12.so.0.50.0
b5b81000 b5ba4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bc5000 b5bd9000 r-xp /usr/lib/libector.so.1.13.0
b5bea000 b5c02000 r-xp /usr/lib/liblua-5.1.so
b5c13000 b5c6a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c7e000 b5ca6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cb7000 b5cca000 r-xp /usr/lib/libfribidi.so.0.3.1
b5cdb000 b5d15000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d26000 b5d34000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d44000 b5d4c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d5c000 b5d69000 r-xp /usr/lib/libeio.so.1.13.0
b5d79000 b5d7b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d8b000 b5d90000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5da0000 b5db7000 r-xp /usr/lib/libefreet.so.1.13.0
b5dc9000 b5de9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5df9000 b5e19000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e1b000 b5e21000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e31000 b5e42000 r-xp /usr/lib/libemotion.so.1.13.0
b5e53000 b5e5a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e6a000 b5e79000 r-xp /usr/lib/libeo.so.1.13.0
b5e8a000 b5e9c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ead000 b5eb2000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ec2000 b5edb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5eeb000 b5f08000 r-xp /usr/lib/libeet.so.1.13.0
b5f21000 b5f69000 r-xp /usr/lib/libeina.so.1.13.0
b5f7a000 b5f8a000 r-xp /usr/lib/libefl.so.1.13.0
b5f9b000 b6080000 r-xp /usr/lib/libicuuc.so.51.1
b609d000 b61dd000 r-xp /usr/lib/libicui18n.so.51.1
b61f4000 b622c000 r-xp /usr/lib/libecore_x.so.1.13.0
b623e000 b6241000 r-xp /lib/libcap.so.2.21
b6251000 b627a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b628b000 b6292000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62a4000 b62db000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62ec000 b63d7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63ea000 b6463000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6475000 b647a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b648a000 b6494000 r-xp /usr/lib/libvconf.so.0.2.45
b64a4000 b64a6000 r-xp /usr/lib/libvasum.so.0.3.1
b64b6000 b64b8000 r-xp /usr/lib/libttrace.so.1.1
b64c8000 b64cb000 r-xp /usr/lib/libiniparser.so.0
b64db000 b6501000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6511000 b6516000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6527000 b653e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b654f000 b65ba000 r-xp /lib/libm-2.20-2014.11.so
b65cb000 b65d1000 r-xp /lib/librt-2.20-2014.11.so
b65e2000 b65ef000 r-xp /usr/lib/libunwind.so.8.0.1
b6625000 b6749000 r-xp /lib/libc-2.20-2014.11.so
b675e000 b6777000 r-xp /lib/libgcc_s-4.9.so.1
b6787000 b6869000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b687a000 b68a4000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68b5000 b68f1000 r-xp /usr/lib/libsystemd.so.0.4.0
b68f3000 b6976000 r-xp /usr/lib/libedje.so.1.13.0
b6989000 b69a7000 r-xp /usr/lib/libecore.so.1.13.0
b69c7000 b6b4e000 r-xp /usr/lib/libevas.so.1.13.0
b6b83000 b6b97000 r-xp /lib/libpthread-2.20-2014.11.so
b6bab000 b6ddf000 r-xp /usr/lib/libelementary.so.1.13.0
b6e0e000 b6e12000 r-xp /usr/lib/libsmack.so.1.0.0
b6e22000 b6e29000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e39000 b6e3b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e4b000 b6e4e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e5e000 b6e60000 r-xp /lib/libdl-2.20-2014.11.so
b6e71000 b6e89000 r-xp /usr/lib/libaul.so.0.1.0
b6e9d000 b6ea2000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eb3000 b6ec0000 r-xp /usr/lib/liblptcp.so
b6ed2000 b6ed6000 r-xp /usr/lib/libsys-assert.so
b6ee7000 b6f07000 r-xp /lib/ld-2.20-2014.11.so
b6f18000 b6f1d000 r-xp /usr/bin/launchpad-loader
b72fe000 b76f2000 rw-p [heap]
bea30000 bea51000 rw-p [stack]
bea30000 bea51000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14052)
Call Stack Count: 21
 0: _ZN8Hoversel16callback_clickedEPvP10_Eo_OpaqueS0_ + 0x13 (0xb2786358) [/opt/usr/apps/org.example.client/bin/client] + 0x1d358
 1: (0xb6a2d7ed) [/usr/lib/libevas.so.1] + 0x667ed
 2: (0xb5e75219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e73fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: evas_object_smart_callback_call + 0x38 (0xb6a2eedd) [/usr/lib/libevas.so.1] + 0x67edd
 5: (0xb694a167) [/usr/lib/libedje.so.1] + 0x57167
 6: (0xb694ed87) [/usr/lib/libedje.so.1] + 0x5bd87
 7: (0xb694ab21) [/usr/lib/libedje.so.1] + 0x57b21
 8: (0xb694aef1) [/usr/lib/libedje.so.1] + 0x57ef1
 9: (0xb694b045) [/usr/lib/libedje.so.1] + 0x58045
10: (0xb6998d11) [/usr/lib/libecore.so.1] + 0xfd11
11: (0xb6994c4b) [/usr/lib/libecore.so.1] + 0xbc4b
12: (0xb699aa5d) [/usr/lib/libecore.so.1] + 0x11a5d
13: ecore_main_loop_begin + 0x3e (0xb699ac83) [/usr/lib/libecore.so.1] + 0x11c83
14: appcore_efl_main + 0x20c (0xb6ea02bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
15: ui_app_main + 0xc0 (0xb3f56909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
16: _ZN6Window10makeWindowEiPPc + 0x11e (0xb278459f) [/opt/usr/apps/org.example.client/bin/client] + 0x1b59f
17: main + 0x40 (0xb276dec1) [/opt/usr/apps/org.example.client/bin/client] + 0x4ec1
18: (0xb6f19bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
19: __libc_start_main + 0x114 (0xb663b4bc) [/lib/libc.so.6] + 0x164bc
20: (0xb6f19eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
 >  appId[org.example.client]
05-31 10:30:10.325+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _DoPkgJob(499) >  #9
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 10:30:10.335+0900 E/PKGMGR_INFO( 1233): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (683) > Application count(1) in this package
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (703) > Exit.
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
05-31 10:30:10.335+0900 I/Tizen::App( 1233): (840) > Enter.
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 E/PKGMGR  ( 1483): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
05-31 10:30:10.345+0900 I/Tizen::App( 1233): (416) > appName = [client]
05-31 10:30:10.345+0900 I/Tizen::App( 1233): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
05-31 10:30:10.345+0900 I/Tizen::App( 1233): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
05-31 10:30:10.345+0900 I/Tizen::App( 1233): (131) > Enter
05-31 10:30:10.365+0900 I/Tizen::App( 1233): (137) > org.example.client does not have launch condition
05-31 10:30:10.365+0900 I/Tizen::App( 1233): (883) > Exit.
05-31 10:30:10.365+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
05-31 10:30:10.365+0900 E/cluster-home(  867): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
05-31 10:30:10.365+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
05-31 10:30:10.385+0900 E/util-view(  867): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
05-31 10:30:11.566+0900 E/PKGMGR_SERVER(21139): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
05-31 10:30:12.397+0900 E/PKGMGR_SERVER(21139): pkgmgr-server.c: sighandler(417) > child NORMAL exit [21142]
05-31 10:30:12.437+0900 W/AUL     (21195): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
05-31 10:30:12.447+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 10:30:12.447+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
05-31 10:30:12.457+0900 I/AUL     (  612): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
05-31 10:30:12.457+0900 E/AUL_AMD (  612): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
05-31 10:30:12.457+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 21195
05-31 10:30:12.457+0900 E/AUL_AMD (  612): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
05-31 10:30:12.467+0900 E/RESOURCED(  678): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
05-31 10:30:12.467+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 10:30:12.467+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(3052) > pad pid(-5)
05-31 10:30:12.467+0900 W/AUL_PAD ( 1497): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
05-31 10:30:12.467+0900 W/AUL_PAD ( 1497): launchpad.c: __send_result_to_caller(267) > Check app launching
05-31 10:30:12.487+0900 I/abc     (14052): abc
05-31 10:30:12.487+0900 I/CAPI_APPFW_APPLICATION(14052): app_main.c: ui_app_main(789) > app_efl_main
05-31 10:30:12.487+0900 I/CAPI_APPFW_APPLICATION(14052): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
05-31 10:30:12.517+0900 E/TBM     (14052): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
05-31 10:30:12.567+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 14052, appid: org.example.client
05-31 10:30:12.567+0900 E/AUL     (  612): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
05-31 10:30:12.587+0900 W/AUL     (21195): launch.c: app_request_to_launchpad(425) > request cmd(0) result(14052)
05-31 10:30:12.587+0900 E/RESOURCED(  678): proc-main.c: proc_add_program_list(237) > not found ppi : org.example.client
05-31 10:30:13.568+0900 E/PKGMGR_SERVER(21139): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 10:30:13.568+0900 E/PKGMGR_SERVER(21139): pkgmgr-server.c: main(2471) > package manager server terminated.
05-31 10:30:13.578+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:30:13.578+0900 W/AUL_AMD (  612): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
05-31 10:30:13.658+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1235
05-31 10:30:13.668+0900 I/Tizen::App( 1233): (499) > LaunchedApp(org.example.client)
05-31 10:30:13.668+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for org.example.client, 14052.
05-31 10:30:14.569+0900 I/UXT     (21207): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
05-31 10:30:17.582+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.client(14052)
05-31 10:30:17.582+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14052, appid: org.example.client, status: bg
05-31 10:30:18.353+0900 I/APP_CORE(14052): appcore-efl.c: __do_app(514) > [APP 14052] Event: RESET State: CREATED
05-31 10:30:18.353+0900 I/CAPI_APPFW_APPLICATION(14052): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
05-31 10:30:18.373+0900 E/EFL     (14052): edje<14052> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:18.373+0900 E/EFL     (14052): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:18.383+0900 E/EFL     (14052): edje<14052> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:18.383+0900 E/EFL     (14052): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:18.383+0900 E/EFL     (14052): edje<14052> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
05-31 10:30:18.383+0900 E/EFL     (14052): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 10:30:18.383+0900 W/APP_CORE(14052): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5e00002
05-31 10:30:18.393+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 35
05-31 10:30:18.503+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(14052) status(4)
05-31 10:30:18.533+0900 I/APP_CORE(14052): appcore-efl.c: __do_app(514) > [APP 14052] Event: PAUSE State: CREATED
05-31 10:30:18.553+0900 I/TIZEN_N_EFL_UTIL_WINDOW(14052): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 19
05-31 10:30:18.553+0900 E/APP_CORE(14052): appcore-efl.c: _capture_and_make_file(1619) > win[5e00002] widget[720] height[1280]
05-31 10:30:18.553+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 33
05-31 10:30:18.863+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(14052) status(0)
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
05-31 10:30:23.177+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
05-31 10:30:23.177+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 10:30:23.177+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(195) > ""
05-31 10:30:23.187+0900 E/LOCKSCREEN(  850): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
05-31 10:30:23.187+0900 E/UXT     (  676): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 10:30
05-31 10:30:23.187+0900 I/INDICATOR(  676): clock.c: getTimeFormatted(176) > "time format : 오전 10:30"
05-31 10:30:23.187+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 10:30"
05-31 10:30:23.187+0900 W/INDICATOR(  676): clock.c: indicator_clock_changed_cb(272) > 
05-31 10:30:23.187+0900 I/INDICATOR(  676): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146120630 Time: <font_size=31> </font_size> <font_size=31> 오전 10:30</font_size></font>"
05-31 10:30:23.187+0900 I/INDICATOR(  676): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
05-31 10:30:23.197+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
05-31 10:30:23.197+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:23.197+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:23.197+0900 E/INDICATOR(  676): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
05-31 10:30:23.197+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:23.197+0900 E/INDICATOR(  676): box.c: _update_icon(232) > (!list) -> _update_icon() return
05-31 10:30:23.407+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
05-31 10:30:23.407+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
05-31 10:30:23.407+0900 W/APP_CORE(  850): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
05-31 10:30:23.407+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: RESUME State: PAUSED
05-31 10:30:23.407+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:30:23.407+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
05-31 10:30:23.407+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
05-31 10:30:23.407+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 10:30:23.407+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
05-31 10:30:23.417+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 0
05-31 10:30:23.417+0900 W/AUL_AMD (  612): amd_launch.c: _start_app(2508) > caller pid : 850
05-31 10:30:23.417+0900 I/AUL_AMD (  612): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
05-31 10:30:23.427+0900 W/AUL_AMD (  612): amd_launch.c: start_process(638) > child process: 21211
05-31 10:30:23.427+0900 E/RESOURCED(  678): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 10:30:23.478+0900 W/AUL_AMD (  612): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 21211
05-31 10:30:23.478+0900 W/AUL     (  612): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 21211, appid: com.samsung.weather-m-agent
05-31 10:30:23.488+0900 I/Tizen::App( 1233): (499) > LaunchedApp(com.samsung.weather-m-agent)
05-31 10:30:23.488+0900 I/Tizen::App( 1233): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 21211.
05-31 10:30:23.498+0900 W/AUL     (  850): launch.c: app_request_to_launchpad(425) > request cmd(0) result(21211)
05-31 10:30:23.658+0900 E/weather-agent(21211): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
05-31 10:30:23.658+0900 E/weather-common(21211): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
05-31 10:30:23.658+0900 E/weather-agent(21211): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
05-31 10:30:23.668+0900 I/MESSAGE_PORT(21211): message-port.c: __initialize(872) > initialize
05-31 10:30:23.678+0900 I/MESSAGE_PORT(21211): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
05-31 10:30:23.708+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 10:30:23.708+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
05-31 10:30:23.708+0900 I/MESSAGE_PORT(  850): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
05-31 10:30:23.718+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:23.718+0900 E/MESSAGE_PORT(21211): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __message_port_send_message(972) > port exist check !!
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
05-31 10:30:23.718+0900 I/MESSAGE_PORT( 1310): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
05-31 10:30:23.718+0900 E/MESSAGE_PORT(21211): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 23.100000[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 28.800000[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 64.600000[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 1[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1496190044[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
05-31 10:30:23.718+0900 E/weather-common(21211): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
05-31 10:30:23.718+0900 E/weather-agent(21211): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
05-31 10:30:23.718+0900 E/weather-agent(21211): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
05-31 10:30:23.718+0900 I/MESSAGE_PORT(21211): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
05-31 10:30:23.728+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:23.748+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:23.798+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
05-31 10:30:23.798+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
05-31 10:30:23.818+0900 I/Tizen::System( 1233): (280) > The screen has been turned on.
05-31 10:30:23.818+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:23.828+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:23.838+0900 W/LOCKSCREEN(  850): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
05-31 10:30:23.888+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757143325
05-31 10:30:24.008+0900 E/EFL     (  850): ecore_x<850> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757143447
05-31 10:30:24.018+0900 E/LOCKSCREEN(  850): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
05-31 10:30:24.018+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
05-31 10:30:24.018+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 10:30:24.048+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8227568]
05-31 10:30:24.048+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 10:30:24.048+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8227568
05-31 10:30:24.048+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 10:30:24.048+0900 W/LOCATION( 1310): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
05-31 10:30:24.048+0900 E/weather-common( 1310): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
05-31 10:30:24.078+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
05-31 10:30:24.078+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_update_cb(287) > received updating signal
05-31 10:30:24.078+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
05-31 10:30:24.088+0900 E/weather-widget( 1310): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
05-31 10:30:24.098+0900 E/weather-common( 1310): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
05-31 10:30:24.108+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_create(409) > New handle created[0xb8282c40]
05-31 10:30:24.108+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_get_type(463) > Connected Network = 2
05-31 10:30:24.108+0900 I/CAPI_NETWORK_CONNECTION( 1310): connection.c: connection_destroy(427) > Destroy handle: 0xb8282c40
05-31 10:30:24.108+0900 E/weather-common( 1310): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
05-31 10:30:24.108+0900 E/weather-widget( 1310): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
05-31 10:30:24.108+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
05-31 10:30:24.108+0900 I/CAPI_WIDGET_APPLICATION( 1310): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
05-31 10:30:24.108+0900 W/AUL     ( 1310): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1310, appid: com.samsung.weather-m-widget, status: fg
05-31 10:30:24.118+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 10:30:24.138+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001483a is not stable during recalc loop
05-31 10:30:24.178+0900 E/EFL     ( 1310): evas_main<1310> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x8001483a is not stable during recalc loop
05-31 10:30:24.178+0900 E/EFL     ( 1310): edje<1310> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 10:30:24.198+0900 E/cluster-home(  867): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
05-31 10:30:24.198+0900 W/cluster-view(  867): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
05-31 10:30:24.348+0900 E/LOCKSCREEN(  850): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
05-31 10:30:24.348+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 10:30:24.348+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 10:30:24.348+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
05-31 10:30:24.358+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:24.368+0900 I/APP_CORE(14052): appcore-efl.c: __do_app(514) > [APP 14052] Event: RESUME State: CREATED
05-31 10:30:24.368+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(850) status(4)
05-31 10:30:24.368+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(850)
05-31 10:30:24.368+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 850, appid: com.samsung.lockscreen, status: bg
05-31 10:30:24.368+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:24.378+0900 I/APP_CORE(14052): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
05-31 10:30:24.378+0900 I/APP_CORE(14052): appcore-efl.c: __do_app(625) > [APP 14052] Initial Launching, call the resume_cb
05-31 10:30:24.378+0900 I/CAPI_APPFW_APPLICATION(14052): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:30:24.378+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(14052) status(3)
05-31 10:30:24.388+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:30:24.388+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 10:30:24.388+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(14052)
05-31 10:30:24.388+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 14052, appid: org.example.client, status: fg
05-31 10:30:24.398+0900 I/Tizen::System( 1233): (259) > Active app [org.exampl], current [com.samsun] 
05-31 10:30:24.398+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:24.408+0900 W/LOCKSCREEN(  850): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
05-31 10:30:24.408+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
05-31 10:30:24.408+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
05-31 10:30:24.408+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:24.418+0900 E/LOCKSCREEN(  850): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
05-31 10:30:24.418+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: PAUSE State: RUNNING
05-31 10:30:24.418+0900 I/CAPI_APPFW_APPLICATION(  850): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
05-31 10:30:24.418+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 10:30:24.418+0900 E/LOCKSCREEN(  850): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
05-31 10:30:24.418+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
05-31 10:30:24.418+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
05-31 10:30:24.418+0900 W/LOCKSCREEN(  850): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
05-31 10:30:24.418+0900 E/LOCKSCREEN(  850): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
05-31 10:30:24.428+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 10:30:24.428+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:24.519+0900 W/LOCKSCREEN(  850): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
05-31 10:30:24.519+0900 E/LOCKSCREEN(  850): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
05-31 10:30:24.519+0900 E/LOCKSCREEN(  850): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
05-31 10:30:24.519+0900 W/LOCKSCREEN(  850): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
05-31 10:30:24.519+0900 W/LOCKSCREEN(  850): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
05-31 10:30:24.519+0900 E/LOCKSCREEN(  850): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
05-31 10:30:24.729+0900 E/weather-agent(21211): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
05-31 10:30:24.729+0900 I/CAPI_APPFW_APPLICATION(21211): service_app_main.c: service_app_exit(446) > service_app_exit
05-31 10:30:24.729+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 22
05-31 10:30:24.729+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(1201) > app status : 5
05-31 10:30:24.729+0900 E/weather-agent(21211): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
05-31 10:30:24.869+0900 W/AUL_AMD (  612): amd_request.c: __send_app_termination_signal(609) > send dead signal done
05-31 10:30:24.869+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21211
05-31 10:30:24.869+0900 I/Tizen::App( 1233): (243) > App[com.samsung.weather-m-agent] pid[21211] terminate event is forwarded
05-31 10:30:24.869+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 10:30:24.869+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 21211, ]
05-31 10:30:24.869+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 10:30:24.869+0900 I/Tizen::App( 1233): (506) > TerminatedApp(com.samsung.weather-m-agent)
05-31 10:30:24.869+0900 I/Tizen::App( 1233): (512) > Not registered pid(21211)
05-31 10:30:24.869+0900 I/Tizen::System( 1233): (246) > Terminated app [com.samsung.weather-m-agent]
05-31 10:30:24.869+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:24.869+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 21211
05-31 10:30:24.879+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:24.879+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 21211.
05-31 10:30:29.423+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
05-31 10:30:29.734+0900 W/AUL_AMD (  612): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
05-31 10:30:29.934+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757149363
05-31 10:30:29.934+0900 I/MY_LOG  (14052): Button pressed
05-31 10:30:30.064+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757149485
05-31 10:30:30.064+0900 E/VCONF   (14052): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
05-31 10:30:30.064+0900 E/VCONF   (14052): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
05-31 10:30:30.064+0900 E/VCONF   (14052): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
05-31 10:30:30.064+0900 E/VCONF   (14052): vconf.c: vconf_get_bool(2729) > vconf_get_bool(14052) : db/ise/keysound error
05-31 10:30:30.074+0900 E/VCONF   (14052): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
05-31 10:30:30.074+0900 E/VCONF   (14052): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
05-31 10:30:30.124+0900 I/MY_LOG  (14052): Button unpressed
05-31 10:30:31.385+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757150821
05-31 10:30:31.385+0900 I/MY_LOG  (14052): Button pressed
05-31 10:30:31.495+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757150932
05-31 10:30:31.495+0900 I/MY_LOG  (14052): Button unpressed
05-31 10:30:31.545+0900 D/basicui (14052): successed to load edc file
05-31 10:30:31.625+0900 I/MY_LOG  (14052): change
05-31 10:30:33.177+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=757152613
05-31 10:30:33.307+0900 E/EFL     (14052): ecore_x<14052> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=757152734
05-31 10:30:33.567+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 14052 pgid = 14052
05-31 10:30:33.567+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(143) > dead_pid(14052)
05-31 10:30:33.567+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:33.617+0900 I/AUL_PAD ( 1497): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
05-31 10:30:33.617+0900 I/AUL_PAD ( 1497): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
05-31 10:30:33.617+0900 E/AUL_PAD ( 1497): launchpad.c: main(698) > error reading sigchld info
05-31 10:30:33.617+0900 W/HOME_APPS(  867): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
05-31 10:30:33.617+0900 I/Tizen::App( 1233): (243) > App[org.example.client] pid[14052] terminate event is forwarded
05-31 10:30:33.617+0900 I/Tizen::System( 1233): (256) > osp.accessorymanager.service provider is found.
05-31 10:30:33.617+0900 I/Tizen::System( 1233): (196) > Accessory Owner is removed [org.example.client, 14052, ]
05-31 10:30:33.617+0900 I/Tizen::System( 1233): (256) > osp.system.service provider is found.
05-31 10:30:33.617+0900 I/Tizen::App( 1233): (506) > TerminatedApp(org.example.client)
05-31 10:30:33.617+0900 I/Tizen::App( 1233): (512) > Not registered pid(14052)
05-31 10:30:33.617+0900 I/Tizen::System( 1233): (246) > Terminated app [org.example.client]
05-31 10:30:33.627+0900 I/Tizen::Io( 1233): (729) > Entry not found
05-31 10:30:33.627+0900 I/ESD     (  894): esd_main.c: __esd_app_dead_handler(1773) > pid: 14052
05-31 10:30:33.627+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 14052
05-31 10:30:33.627+0900 W/AUL_AMD (  612): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 14052
05-31 10:30:33.637+0900 E/RESOURCED(  678): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1241
05-31 10:30:33.647+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(3)
05-31 10:30:33.647+0900 W/AUL_AMD (  612): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 10:30:33.647+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
05-31 10:30:33.647+0900 W/AUL     (  612): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(867)
05-31 10:30:33.647+0900 W/AUL     (  612): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 867, appid: com.samsung.homescreen, status: fg
05-31 10:30:33.647+0900 W/AUL_AMD (  612): amd_launch.c: __e17_status_handler(3328) > pid(867) status(0)
05-31 10:30:33.657+0900 I/Tizen::System( 1233): (157) > change brightness system value.
05-31 10:30:33.657+0900 I/Tizen::App( 1233): (782) > Finished invoking application event listener for org.example.client, 14052.
05-31 10:30:33.667+0900 E/EFL     (  335): eo<335> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
05-31 10:30:33.667+0900 I/APP_CORE(  867): appcore-efl.c: __do_app(514) > [APP 867] Event: RESUME State: PAUSED
05-31 10:30:33.667+0900 I/CAPI_APPFW_APPLICATION(  867): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
05-31 10:30:33.667+0900 E/cluster-home(  867): homescreen.cpp: OnResume(233) >  app resume
05-31 10:30:33.707+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
05-31 10:30:33.707+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:33.707+0900 I/TIZEN_N_SOUND_MANAGER(  913): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
05-31 10:30:33.707+0900 E/TIZEN_N_SOUND_MANAGER(  913): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-31 10:30:33.718+0900 W/AUL_AMD (  612): amd_request.c: __request_handler(906) > __request_handler: 15
05-31 10:30:33.718+0900 W/CRASH_MANAGER(21224): worker.c: worker_job(1199) > 1114052636c69149619423
