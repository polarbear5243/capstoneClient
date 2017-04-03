S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 13476
Date: 2017-04-01 23:27:42+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 13476, uid 5000)

Register Information
r0   = 0xb8441c40, r1   = 0xb33c33ae
r2   = 0x80000000, r3   = 0x00000069
r4   = 0xb5ab501f, r5   = 0x00000000
r6   = 0x00000001, r7   = 0xbee0bf38
r8   = 0xbee0c478, r9   = 0xb8282d90
r10  = 0xbee0c498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbee0be98
lr   = 0x64656d2f, pc   = 0xb33c101c
cpsr = 0xa0030030

Memory Information
MemTotal:   987012 KB
MemFree:    129368 KB
Buffers:     50796 KB
Cached:     283296 KB
VmPeak:      98428 KB
VmSize:      98424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19436 KB
VmRSS:       19436 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35644 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 13476 TID = 13476
13476 13481 14093 14094 

Maps Information
b1407000 b140f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1421000 b1c20000 rw-p [stack:14094]
b1c20000 b1c21000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c31000 b1c45000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c59000 b1c5a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c6a000 b1c6d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c7e000 b1c7f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c8f000 b1c91000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1ca1000 b1ca3000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1cb3000 b1cc3000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cd3000 b1cdf000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cf1000 b24f0000 rw-p [stack:14093]
b2821000 b2828000 r-xp /usr/lib/libefl-extension.so.0.1.0
b283b000 b2841000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2851000 b2861000 r-xp /opt/usr/apps/org.example.client/bin/client
b29aa000 b2a8d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ac4000 b2aec000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2afe000 b32fd000 rw-p [stack:13481]
b32fd000 b32ff000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b330f000 b3319000 r-xp /lib/libnss_files-2.20-2014.11.so
b332a000 b3333000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3344000 b3355000 r-xp /lib/libnsl-2.20-2014.11.so
b3368000 b336e000 r-xp /lib/libnss_compat-2.20-2014.11.so
b337f000 b3380000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33a8000 b33af000 r-xp /usr/lib/libminizip.so.1.0.0
b33bf000 b33c4000 r-xp /usr/lib/libstorage.so.0.1
b33d4000 b3433000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3449000 b345d000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b346d000 b34b1000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34c1000 b34c9000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34d9000 b3509000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b351c000 b35d5000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35e9000 b363c000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b364d000 b3668000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3678000 b3739000 r-xp /usr/lib/libprotobuf.so.9.0.1
b374c000 b375c000 r-xp /usr/lib/libefl-assist.so.0.1.0
b376c000 b3779000 r-xp /usr/lib/libmdm-common.so.1.0.98
b378a000 b3791000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37a1000 b37e2000 r-xp /usr/lib/libmdm.so.1.2.12
b37f2000 b37fa000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3809000 b3819000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b383a000 b389a000 r-xp /usr/lib/libasound.so.2.0.0
b38ac000 b38af000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38bf000 b38c2000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38d2000 b38d7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38e7000 b38e8000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38f8000 b3903000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3917000 b391e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b392e000 b3934000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3944000 b3949000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3959000 b3974000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3984000 b398b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b399b000 b399e000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39af000 b39dd000 r-xp /usr/lib/libidn.so.11.5.44
b39ed000 b3a03000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a14000 b3a1e000 r-xp /usr/lib/libcares.so.2.1.0
b3a2e000 b3a38000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a48000 b3a4a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a5a000 b3a5b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a6b000 b3a6f000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a80000 b3aa8000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ab9000 b3ae2000 r-xp /usr/lib/libturbojpeg.so
b3b02000 b3b08000 r-xp /usr/lib/libgif.so.4.1.6
b3b18000 b3b5e000 r-xp /usr/lib/libcurl.so.4.3.0
b3b6f000 b3b90000 r-xp /usr/lib/libexif.so.12.3.3
b3bab000 b3bc0000 r-xp /usr/lib/libtts.so
b3bd1000 b3bd9000 r-xp /usr/lib/libfeedback.so.0.1.4
b3be9000 b3caf000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ccf000 b3dc7000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3de6000 b3eb4000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ecb000 b3ecd000 r-xp /usr/lib/libboost_system.so.1.51.0
b3edd000 b3ee3000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ef3000 b3f16000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f27000 b3f29000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f39000 b3f3b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f4c000 b3f51000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f68000 b3f6a000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f7a000 b3f81000 r-xp /usr/lib/libsensord-share.so
b3f91000 b3fa9000 r-xp /usr/lib/libsensor.so.1.1.0
b3fba000 b3fbd000 r-xp /usr/lib/libXv.so.1.0.0
b3fcd000 b3fd2000 r-xp /usr/lib/libutilX.so.1.1.0
b3fe2000 b3fe7000 r-xp /usr/lib/libappcore-common.so.1.1
b3ff7000 b3ffe000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4011000 b4015000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4026000 b4104000 r-xp /usr/lib/libCOREGL.so.4.0
b4124000 b4127000 r-xp /usr/lib/libuuid.so.1.3.0
b4137000 b414e000 r-xp /usr/lib/libblkid.so.1.1.0
b415f000 b4161000 r-xp /usr/lib/libXau.so.6.0.0
b4171000 b41b8000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41ca000 b41d0000 r-xp /usr/lib/libjson-c.so.2.0.1
b41e1000 b41e5000 r-xp /usr/lib/libogg.so.0.7.1
b41f5000 b4217000 r-xp /usr/lib/libvorbis.so.0.4.3
b4227000 b430b000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4327000 b432a000 r-xp /usr/lib/libEGL.so.1.4
b433b000 b4341000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4351000 b4353000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4363000 b4370000 r-xp /usr/lib/libGLESv2.so.2.0
b4381000 b43e3000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43f8000 b4410000 r-xp /usr/lib/libmount.so.1.1.0
b4422000 b4436000 r-xp /usr/lib/libxcb.so.1.1.0
b4446000 b444d000 r-xp /lib/libcrypt-2.20-2014.11.so
b4485000 b4487000 r-xp /usr/lib/libiri.so
b4497000 b44a2000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44b3000 b44e9000 r-xp /usr/lib/libpulse.so.0.16.2
b44fa000 b453d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4552000 b4567000 r-xp /lib/libexpat.so.1.5.2
b4579000 b4637000 r-xp /usr/lib/libcairo.so.2.11200.14
b464b000 b4653000 r-xp /usr/lib/libdrm.so.2.4.0
b4663000 b4666000 r-xp /usr/lib/libdri2.so.0.0.0
b4676000 b46c4000 r-xp /usr/lib/libssl.so.1.0.0
b46d9000 b46e5000 r-xp /usr/lib/libeeze.so.1.13.0
b46f6000 b46ff000 r-xp /usr/lib/libethumb.so.1.13.0
b470f000 b4712000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4722000 b48d9000 r-xp /usr/lib/libcrypto.so.1.0.0
b56c4000 b56cd000 r-xp /usr/lib/libXi.so.6.1.0
b56dd000 b56df000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ef000 b56f3000 r-xp /usr/lib/libXtst.so.6.1.0
b5703000 b5709000 r-xp /usr/lib/libXrender.so.1.3.0
b5719000 b571f000 r-xp /usr/lib/libXrandr.so.2.2.0
b572f000 b5731000 r-xp /usr/lib/libXinerama.so.1.0.0
b5742000 b5745000 r-xp /usr/lib/libXfixes.so.3.1.0
b5755000 b5760000 r-xp /usr/lib/libXext.so.6.4.0
b5770000 b5772000 r-xp /usr/lib/libXdamage.so.1.1.0
b5782000 b5784000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5794000 b5876000 r-xp /usr/lib/libX11.so.6.3.0
b588a000 b5891000 r-xp /usr/lib/libXcursor.so.1.0.2
b58a1000 b58b9000 r-xp /usr/lib/libudev.so.1.6.0
b58bb000 b58be000 r-xp /lib/libattr.so.1.1.0
b58ce000 b58ee000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ef000 b58f4000 r-xp /usr/lib/libffi.so.6.0.2
b5905000 b591d000 r-xp /lib/libz.so.1.2.8
b592d000 b592f000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b593f000 b5a14000 r-xp /usr/lib/libxml2.so.2.9.2
b5a29000 b5ac4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ae0000 b5ae3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5af3000 b5b0c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b1d000 b5b2e000 r-xp /lib/libresolv-2.20-2014.11.so
b5b42000 b5bbc000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bd1000 b5bd3000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5be3000 b5bea000 r-xp /usr/lib/libembryo.so.1.13.0
b5bfa000 b5c04000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c15000 b5c2d000 r-xp /usr/lib/libpng12.so.0.50.0
b5c3e000 b5c61000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c82000 b5c96000 r-xp /usr/lib/libector.so.1.13.0
b5ca7000 b5cbf000 r-xp /usr/lib/liblua-5.1.so
b5cd0000 b5d27000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d3b000 b5d63000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d74000 b5d87000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d98000 b5dd2000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5de3000 b5df1000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e01000 b5e09000 r-xp /usr/lib/libtbm.so.1.0.0
b5e19000 b5e26000 r-xp /usr/lib/libeio.so.1.13.0
b5e36000 b5e38000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e48000 b5e4d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e5d000 b5e74000 r-xp /usr/lib/libefreet.so.1.13.0
b5e86000 b5ea6000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eb6000 b5ed6000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ed8000 b5ede000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eee000 b5eff000 r-xp /usr/lib/libemotion.so.1.13.0
b5f10000 b5f17000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f27000 b5f36000 r-xp /usr/lib/libeo.so.1.13.0
b5f47000 b5f59000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f6a000 b5f6f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f7f000 b5f98000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fa8000 b5fc5000 r-xp /usr/lib/libeet.so.1.13.0
b5fde000 b6026000 r-xp /usr/lib/libeina.so.1.13.0
b6037000 b6047000 r-xp /usr/lib/libefl.so.1.13.0
b6058000 b613d000 r-xp /usr/lib/libicuuc.so.51.1
b615a000 b629a000 r-xp /usr/lib/libicui18n.so.51.1
b62b1000 b62e9000 r-xp /usr/lib/libecore_x.so.1.13.0
b62fb000 b62fe000 r-xp /lib/libcap.so.2.21
b630e000 b6337000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6348000 b634f000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6361000 b6398000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63a9000 b6494000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64a7000 b6520000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6532000 b6537000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6547000 b6551000 r-xp /usr/lib/libvconf.so.0.2.45
b6561000 b6563000 r-xp /usr/lib/libvasum.so.0.3.1
b6573000 b6575000 r-xp /usr/lib/libttrace.so.1.1
b6585000 b6588000 r-xp /usr/lib/libiniparser.so.0
b6598000 b65be000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ce000 b65d3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65e4000 b65fb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b660c000 b6677000 r-xp /lib/libm-2.20-2014.11.so
b6688000 b668e000 r-xp /lib/librt-2.20-2014.11.so
b669f000 b66ac000 r-xp /usr/lib/libunwind.so.8.0.1
b66e2000 b6806000 r-xp /lib/libc-2.20-2014.11.so
b681b000 b6834000 r-xp /lib/libgcc_s-4.9.so.1
b6844000 b6926000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6937000 b6961000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6972000 b69ae000 r-xp /usr/lib/libsystemd.so.0.4.0
b69b0000 b6a33000 r-xp /usr/lib/libedje.so.1.13.0
b6a46000 b6a64000 r-xp /usr/lib/libecore.so.1.13.0
b6a84000 b6c0b000 r-xp /usr/lib/libevas.so.1.13.0
b6c40000 b6c54000 r-xp /lib/libpthread-2.20-2014.11.so
b6c68000 b6e9c000 r-xp /usr/lib/libelementary.so.1.13.0
b6ecb000 b6ecf000 r-xp /usr/lib/libsmack.so.1.0.0
b6edf000 b6ee6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ef6000 b6ef8000 r-xp /usr/lib/libdlog.so.0.0.0
b6f08000 b6f0b000 r-xp /usr/lib/libbundle.so.0.1.22
b6f1b000 b6f1d000 r-xp /lib/libdl-2.20-2014.11.so
b6f2e000 b6f46000 r-xp /usr/lib/libaul.so.0.1.0
b6f5a000 b6f5f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f70000 b6f7d000 r-xp /usr/lib/liblptcp.so
b6f8f000 b6f93000 r-xp /usr/lib/libsys-assert.so
b6fa4000 b6fc4000 r-xp /lib/ld-2.20-2014.11.so
b6fd5000 b6fda000 r-xp /usr/bin/launchpad-loader
b8243000 b846e000 rw-p [heap]
bedec000 bee0d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13476)
Call Stack Count: 15
 0: storage_get_root_directory + 0x1f (0xb33c101c) [/usr/lib/libstorage.so.0.1] + 0x201c
 1: _ZN9FileInputC2ESs + 0x28 (0xb2855c99) [/opt/usr/apps/org.example.client/bin/client] + 0x4c99
 2: _ZN7MyLogin6drawUIEP9Naviframe + 0x40 (0xb2854b35) [/opt/usr/apps/org.example.client/bin/client] + 0x3b35
 3: _ZN7MyLoginC2EP9Naviframe + 0x48 (0xb2854ac9) [/opt/usr/apps/org.example.client/bin/client] + 0x3ac9
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb28548fd) [/opt/usr/apps/org.example.client/bin/client] + 0x38fd
 5: _ZN6Window10app_createEPv + 0x8e (0xb285a66f) [/opt/usr/apps/org.example.client/bin/client] + 0x966f
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb285a7e9) [/opt/usr/apps/org.example.client/bin/client] + 0x97e9
 7: (0xb40134f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6f5d203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb4013909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb285ab73) [/opt/usr/apps/org.example.client/bin/client] + 0x9b73
11: main + 0x40 (0xb2854685) [/opt/usr/apps/org.example.client/bin/client] + 0x3685
12: (0xb6fd6bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb66f84bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6fd6eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
 dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-01 23:25:10.249+0900 E/LOCKSCREEN(  859): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-01 23:25:10.249+0900 E/LOCKSCREEN(  859): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-01 23:25:10.249+0900 E/LOCKSCREEN(  859): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-01 23:25:10.249+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-01 23:25:10.249+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-01 23:25:10.549+0900 E/VOLUME  (  871): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-01 23:25:10.549+0900 E/VOLUME  (  871): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
04-01 23:25:10.569+0900 W/LOCKSCREEN(  859): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
04-01 23:25:15.164+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: MEM_FLUSH State: PAUSED
04-01 23:27:27.873+0900 E/PKGMGR_SERVER(13876): pkgmgr-server.c: main(2414) > package manager server start
04-01 23:27:27.953+0900 E/PKGMGR  (13874): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
04-01 23:27:27.993+0900 W/LOCKSCREEN(  859): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
04-01 23:27:28.004+0900 E/LOCKSCREEN(  859): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-01 23:27:28.004+0900 E/LOCKSCREEN(  859): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
04-01 23:27:28.014+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(195) > ""
04-01 23:27:28.054+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 14
04-01 23:27:28.054+0900 E/AUL_AMD (  605): amd_status.c: _status_app_is_running_from_cache(827) > is_running garbage, pid: 13643
04-01 23:27:28.054+0900 E/UXT     (  683): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:27
04-01 23:27:28.054+0900 I/INDICATOR(  683): clock.c: getTimeFormatted(176) > "time format : 오후 11:27"
04-01 23:27:28.054+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:27"
04-01 23:27:28.054+0900 W/INDICATOR(  683): clock.c: indicator_clock_changed_cb(272) > 
04-01 23:27:28.054+0900 I/INDICATOR(  683): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146533842 Time: <font_size=31> </font_size> <font_size=31> 오후 11:27</font_size></font>"
04-01 23:27:28.054+0900 I/INDICATOR(  683): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
04-01 23:27:28.064+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-01 23:27:28.064+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:27:28.064+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:27:28.064+0900 E/INDICATOR(  683): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-01 23:27:28.064+0900 W/AUL_AMD (  605): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-01 23:27:28.064+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:27:28.064+0900 E/INDICATOR(  683): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-01 23:27:28.074+0900 E/PKGMGR_SERVER(13876): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13879]
04-01 23:27:28.364+0900 W/LOCKSCREEN(  859): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
04-01 23:27:28.364+0900 W/LOCKSCREEN(  859): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
04-01 23:27:28.364+0900 W/APP_CORE(  859): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
04-01 23:27:28.364+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: RESUME State: PAUSED
04-01 23:27:28.364+0900 I/CAPI_APPFW_APPLICATION(  859): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 23:27:28.364+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
04-01 23:27:28.364+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
04-01 23:27:28.364+0900 W/LOCKSCREEN(  859): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-01 23:27:28.364+0900 E/LOCKSCREEN(  859): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-01 23:27:28.374+0900 W/AUL     (  859): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-01 23:27:28.374+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 23:27:28.374+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(2508) > caller pid : 859
04-01 23:27:28.374+0900 I/AUL_AMD (  605): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-01 23:27:28.384+0900 W/AUL_AMD (  605): amd_launch.c: start_process(638) > child process: 13886
04-01 23:27:28.384+0900 E/RESOURCED(  685): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 23:27:28.434+0900 W/AUL_AMD (  605): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 13886
04-01 23:27:28.434+0900 W/AUL     (  605): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 13886, appid: com.samsung.weather-m-agent
04-01 23:27:28.434+0900 W/AUL     (  859): launch.c: app_request_to_launchpad(425) > request cmd(0) result(13886)
04-01 23:27:28.444+0900 I/Tizen::App( 1247): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-01 23:27:28.444+0900 I/Tizen::App( 1247): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 13886.
04-01 23:27:28.594+0900 E/weather-agent(13886): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
04-01 23:27:28.594+0900 E/weather-common(13886): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
04-01 23:27:28.594+0900 E/weather-agent(13886): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
04-01 23:27:28.614+0900 I/MESSAGE_PORT(13886): message-port.c: __initialize(872) > initialize
04-01 23:27:28.624+0900 I/MESSAGE_PORT(13886): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
04-01 23:27:28.624+0900 I/Tizen::System( 1247): (280) > The screen has been turned on.
04-01 23:27:28.624+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 23:27:28.624+0900 W/LOCKSCREEN(  859): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
04-01 23:27:28.634+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __message_port_send_message(972) > port exist check !!
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-01 23:27:28.654+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
04-01 23:27:28.654+0900 I/MESSAGE_PORT(  859): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __message_port_send_message(972) > port exist check !!
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-01 23:27:28.654+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:27:28.654+0900 E/MESSAGE_PORT(13886): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
04-01 23:27:28.654+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __message_port_send_message(972) > port exist check !!
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __message_port_send_message(972) > port exist check !!
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
04-01 23:27:28.654+0900 I/MESSAGE_PORT(13886): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-01 23:27:28.654+0900 I/MESSAGE_PORT( 1420): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-01 23:27:28.654+0900 E/MESSAGE_PORT(13886): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
04-01 23:27:28.654+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
04-01 23:27:28.654+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 9.800000[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 14.300000[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 35.800000[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1491045744[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
04-01 23:27:28.664+0900 E/weather-common(13886): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
04-01 23:27:28.664+0900 E/weather-agent(13886): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
04-01 23:27:28.664+0900 E/weather-agent(13886): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
04-01 23:27:28.664+0900 I/MESSAGE_PORT(13886): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-01 23:27:28.664+0900 I/MESSAGE_PORT(13886): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-01 23:27:28.664+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:27:28.684+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:27:28.724+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-01 23:27:28.724+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-01 23:27:28.794+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=33457564
04-01 23:27:28.984+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_create(409) > New handle created[0xb8c148e8]
04-01 23:27:28.984+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_get_type(463) > Connected Network = 2
04-01 23:27:28.984+0900 I/CAPI_NETWORK_CONNECTION( 1420): connection.c: connection_destroy(427) > Destroy handle: 0xb8c148e8
04-01 23:27:28.994+0900 E/weather-common( 1420): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-01 23:27:28.994+0900 W/LOCATION( 1420): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-01 23:27:28.994+0900 E/weather-common( 1420): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-01 23:27:29.004+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=33457765
04-01 23:27:29.004+0900 E/LOCKSCREEN(  859): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-01 23:27:29.014+0900 E/LOCKSCREEN(  859): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-01 23:27:29.024+0900 E/weather-widget( 1420): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-01 23:27:29.024+0900 I/CAPI_WIDGET_APPLICATION( 1420): widget_app.c: __provider_update_cb(287) > received updating signal
04-01 23:27:29.035+0900 E/EFL     ( 1420): edje<1420> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-01 23:27:29.055+0900 E/EFL     ( 1420): evas_main<1420> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801ed8ad is not stable during recalc loop
04-01 23:27:29.095+0900 E/EFL     ( 1420): evas_main<1420> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x801ed8ad is not stable during recalc loop
04-01 23:27:29.105+0900 E/EFL     ( 1420): edje<1420> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-01 23:27:29.125+0900 E/cluster-home(  878): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-01 23:27:29.135+0900 W/cluster-view(  878): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-01 23:27:29.305+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=33458059
04-01 23:27:29.485+0900 E/EFL     (  859): ecore_x<859> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=33458238
04-01 23:27:29.485+0900 E/LOCKSCREEN(  859): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
04-01 23:27:29.485+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
04-01 23:27:29.485+0900 E/LOCKSCREEN(  859): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-01 23:27:29.665+0900 E/weather-agent(13886): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-01 23:27:29.665+0900 I/CAPI_APPFW_APPLICATION(13886): service_app_main.c: service_app_exit(446) > service_app_exit
04-01 23:27:29.665+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 22
04-01 23:27:29.665+0900 E/weather-agent(13886): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-01 23:27:29.665+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(1201) > app status : 5
04-01 23:27:29.795+0900 W/AUL_AMD (  605): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-01 23:27:29.805+0900 I/Tizen::App( 1247): (243) > App[com.samsung.weather-m-agent] pid[13886] terminate event is forwarded
04-01 23:27:29.805+0900 I/Tizen::System( 1247): (256) > osp.accessorymanager.service provider is found.
04-01 23:27:29.805+0900 I/Tizen::System( 1247): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 13886, ]
04-01 23:27:29.805+0900 I/Tizen::System( 1247): (256) > osp.system.service provider is found.
04-01 23:27:29.805+0900 I/Tizen::App( 1247): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-01 23:27:29.805+0900 I/Tizen::App( 1247): (512) > Not registered pid(13886)
04-01 23:27:29.805+0900 I/Tizen::System( 1247): (246) > Terminated app [com.samsung.weather-m-agent]
04-01 23:27:29.805+0900 I/Tizen::Io( 1247): (729) > Entry not found
04-01 23:27:29.805+0900 I/ESD     (  913): esd_main.c: __esd_app_dead_handler(1773) > pid: 13886
04-01 23:27:29.805+0900 W/AUL_AMD (  605): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 13886
04-01 23:27:29.805+0900 I/Tizen::System( 1247): (157) > change brightness system value.
04-01 23:27:29.805+0900 I/Tizen::App( 1247): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 13886.
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-01 23:27:29.835+0900 E/LOCKSCREEN(  859): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-01 23:27:29.835+0900 E/LOCKSCREEN(  859): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-01 23:27:29.835+0900 E/LOCKSCREEN(  859): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-01 23:27:29.835+0900 W/LOCKSCREEN(  859): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-01 23:27:29.845+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:27:29.845+0900 E/EFL     (  340): eo<340> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-01 23:27:29.845+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(859) status(4)
04-01 23:27:29.845+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(859)
04-01 23:27:29.845+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 859, appid: com.samsung.lockscreen, status: bg
04-01 23:27:29.855+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3328) > pid(13521) status(3)
04-01 23:27:29.855+0900 W/LOCKSCREEN(  859): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x3000007] is [invisible]
04-01 23:27:29.855+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-01 23:27:29.855+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-01 23:27:29.865+0900 I/APP_CORE(13521): appcore-efl.c: __do_app(514) > [APP 13521] Event: RESUME State: PAUSED
04-01 23:27:29.865+0900 I/CAPI_APPFW_APPLICATION(13521): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-01 23:27:29.865+0900 E/LOCKSCREEN(  859): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-01 23:27:29.865+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: PAUSE State: RUNNING
04-01 23:27:29.865+0900 I/CAPI_APPFW_APPLICATION(  859): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-01 23:27:29.865+0900 E/LOCKSCREEN(  859): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-01 23:27:29.865+0900 E/LOCKSCREEN(  859): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-01 23:27:29.865+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-01 23:27:29.865+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-01 23:27:29.865+0900 W/LOCKSCREEN(  859): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-01 23:27:29.865+0900 E/LOCKSCREEN(  859): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-01 23:27:29.865+0900 W/AUL_AMD (  605): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 23:27:29.865+0900 W/AUL_AMD (  605): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-01 23:27:29.865+0900 W/AUL     (  605): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.myfile-lite(13521)
04-01 23:27:29.865+0900 W/AUL     (  605): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 13521, appid: com.samsung.myfile-lite, status: fg
04-01 23:27:29.885+0900 I/Tizen::System( 1247): (259) > Active app [com.samsun], current [com.samsun] 
04-01 23:27:29.885+0900 I/Tizen::System( 1247): (273) > Current App[com.samsun] is already actived.
04-01 23:27:29.895+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: MEM_FLUSH State: PAUSED
04-01 23:27:29.905+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 15
04-01 23:27:29.965+0900 W/LOCKSCREEN(  859): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-01 23:27:29.965+0900 E/LOCKSCREEN(  859): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-01 23:27:29.965+0900 E/LOCKSCREEN(  859): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-01 23:27:29.965+0900 W/LOCKSCREEN(  859): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-01 23:27:29.965+0900 W/LOCKSCREEN(  859): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-01 23:27:29.975+0900 E/LOCKSCREEN(  859): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-01 23:27:30.236+0900 E/PKGMGR_SERVER(13876): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 23:27:30.236+0900 E/PKGMGR_SERVER(13876): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 23:27:31.957+0900 E/PKGMGR  (13975): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-01 23:27:32.037+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: main(2414) > package manager server start
04-01 23:27:32.087+0900 E/PKGMGR_SERVER(13977): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-01 23:27:32.097+0900 E/PKGMGR_SERVER(13977): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-01 23:27:32.097+0900 E/PKGMGR  (13975): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[139750002]
04-01 23:27:32.248+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-01 23:27:32.258+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-01 23:27:32.258+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.258+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.258+0900 W/AUL_AMD (  605): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-01 23:27:32.268+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 23:27:32.268+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [30]
04-01 23:27:32.268+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-01 23:27:32.268+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.268+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.408+0900 W/CERT_SVC_VCORE(13980): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 23:27:32.468+0900 E/rpm-installer(13980): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-01 23:27:32.468+0900 E/rpm-installer(13980): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-01 23:27:32.518+0900 E/PKGMGR_PARSER(13980): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-01 23:27:32.528+0900 I/PRIVACY-MANAGER-CLIENT(13980): SocketClient.cpp: SocketClient(37) > Client created
04-01 23:27:32.528+0900 I/PRIVACY-MANAGER-CLIENT(13980): SocketClient.cpp: connect(62) > Client connected
04-01 23:27:32.528+0900 I/PRIVACY-MANAGER-SERVER(  937): SocketService.cpp: mainloop(230) > Got incoming connection
04-01 23:27:32.528+0900 I/PRIVACY-MANAGER-CLIENT(13980): SocketClient.cpp: disconnect(72) > Client disconnected
04-01 23:27:32.538+0900 E/PKGMGR_CERT(13980): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-01 23:27:32.538+0900 E/PKGMGR_CERT(13980): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-01 23:27:32.548+0900 E/PKGMGR_CERT(13980): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-01 23:27:32.578+0900 E/rpm-installer(13980): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-01 23:27:32.588+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-01 23:27:32.588+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [96]
04-01 23:27:32.588+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.588+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:32.588+0900 E/ESD     (  913): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-01 23:27:32.588+0900 W/AUL_AMD (  605): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-01 23:27:32.598+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-01 23:27:32.598+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-01 23:27:34.230+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 23:27:34.260+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: sighandler(417) > child NORMAL exit [13980]
04-01 23:27:34.660+0900 W/AUL_AMD (  605): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-01 23:27:34.860+0900 I/APP_CORE(  859): appcore-efl.c: __do_app(514) > [APP 859] Event: MEM_FLUSH State: PAUSED
04-01 23:27:35.020+0900 E/PKGMGR  (14029): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-01 23:27:35.050+0900 E/PKGMGR_SERVER(13977): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-01 23:27:35.060+0900 E/PKGMGR_INFO(13977): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-01 23:27:35.070+0900 E/rpm-installer(13977): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-01 23:27:35.080+0900 E/PKGMGR_SERVER(13977): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-01 23:27:35.080+0900 E/PKGMGR  (14029): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[140290002]
04-01 23:27:35.201+0900 E/PKGMGR_INSTALLER(14031): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-01 23:27:35.201+0900 E/rpm-installer(14031): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-01 23:27:35.221+0900 E/rpm-installer(14031): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-01 23:27:35.221+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-01 23:27:35.221+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 23:27:35.221+0900 E/rpm-installer(14031): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-01 23:27:35.221+0900 E/rpm-installer(14031): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 23:27:35.271+0900 W/CERT_SVC_VCORE(14031): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-01 23:27:35.331+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-01 23:27:35.331+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [96]
04-01 23:27:35.331+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.331+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.341+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-01 23:27:35.341+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [30]
04-01 23:27:35.341+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [96]
04-01 23:27:35.341+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.341+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-01 23:27:35.521+0900 E/rpm-installer(14031): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-01 23:27:35.521+0900 E/PKGMGR_PARSER(14031): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-01 23:27:35.531+0900 E/PKGMGR_PARSER(14031): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-01 23:27:35.561+0900 I/PRIVACY-MANAGER-CLIENT(14031): SocketClient.cpp: SocketClient(37) > Client created
04-01 23:27:35.771+0900 E/PKGMGR_PARSER(14031): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-01 23:27:35.791+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-01 23:27:35.801+0900 E/PKGMGR_CERT(14031): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-01 23:27:35.801+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-01 23:27:35.801+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [60]
04-01 23:27:35.801+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [96]
04-01 23:27:35.801+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.801+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.821+0900 E/rpm-installer(14031): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-01 23:27:35.841+0900 E/rpm-installer(14031): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-01 23:27:35.841+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-01 23:27:35.841+0900 I/Tizen::App( 1247): (119) > InstallationInProgress [100]
04-01 23:27:35.841+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-01 23:27:35.841+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:35.841+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:36.232+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-01 23:27:37.743+0900 I/Tizen::App( 1247): (1894) > PackageEventHandler - req: 12470002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-01 23:27:37.743+0900 I/Tizen::App( 1247): (78) > Installation is Completed. [Package = org.example.client]
04-01 23:27:37.743+0900 I/Tizen::App( 1247): (671) > Enter. package(org.example.client), installationResult(0)
04-01 23:27:37.753+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:37.753+0900 E/PKGMGR  ( 1502): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
04-01 23:27:37.753+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-01 23:27:37.753+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-01 23:27:37.753+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-01 23:27:37.793+0900 I/Tizen::App( 1247): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-01 23:27:37.793+0900 W/ISF_PANEL_EFL(  775): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-01 23:27:37.823+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: sighandler(417) > child NORMAL exit [14031]
04-01 23:27:37.823+0900 I/Tizen::App( 1247): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-01 23:27:37.833+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-01 23:27:37.833+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-01 23:27:37.833+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-01 23:27:37.833+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-01 23:27:37.833+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-01 23:27:37.853+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-01 23:27:37.853+0900 E/HOME_APPS(  878): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-01 23:27:37.853+0900 E/cluster-home(  878): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-01 23:27:37.863+0900 W/HOME_APPS(  878): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (416) > appName = [client]
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 23:27:37.863+0900 E/PKGMGR_INFO( 1247): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (683) > Application count(1) in this package
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (840) > Enter.
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (703) > Exit.
04-01 23:27:37.863+0900 I/Tizen::App( 1247): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (416) > appName = [client]
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (131) > Enter
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (137) > org.example.client does not have launch condition
04-01 23:27:37.873+0900 I/Tizen::App( 1247): (883) > Exit.
04-01 23:27:37.883+0900 E/util-view(  878): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-01 23:27:38.233+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-01 23:27:38.233+0900 E/PKGMGR_SERVER(13977): pkgmgr-server.c: main(2471) > package manager server terminated.
04-01 23:27:41.917+0900 W/AUL     (14086): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-01 23:27:41.917+0900 W/AUL_AMD (  605): amd_request.c: __request_handler(906) > __request_handler: 0
04-01 23:27:41.927+0900 I/AUL     (  605): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-01 23:27:41.937+0900 I/AUL     (  605): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-01 23:27:41.937+0900 E/AUL_AMD (  605): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-01 23:27:41.937+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(2508) > caller pid : 14086
04-01 23:27:41.937+0900 E/AUL_AMD (  605): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-01 23:27:41.947+0900 E/RESOURCED(  685): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 9
04-01 23:27:41.947+0900 E/RESOURCED(  685): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 23:27:41.947+0900 W/AUL_AMD (  605): amd_launch.c: _start_app(3052) > pad pid(-5)
04-01 23:27:41.947+0900 W/AUL_PAD ( 1508): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-01 23:27:41.947+0900 W/AUL_PAD ( 1508): launchpad.c: __send_result_to_caller(267) > Check app launching
04-01 23:27:41.967+0900 I/abc     (13476): abc
04-01 23:27:41.967+0900 I/CAPI_APPFW_APPLICATION(13476): app_main.c: ui_app_main(789) > app_efl_main
04-01 23:27:41.967+0900 I/CAPI_APPFW_APPLICATION(13476): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-01 23:27:41.997+0900 E/TBM     (13476): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-01 23:27:42.047+0900 W/AUL     (  605): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 13476, appid: org.example.client
04-01 23:27:42.047+0900 E/AUL     (  605): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-01 23:27:42.067+0900 W/AUL     (14086): launch.c: app_request_to_launchpad(425) > request cmd(0) result(13476)
04-01 23:27:42.368+0900 W/CRASH_MANAGER(14101): worker.c: worker_job(1199) > 1113476636c69149105686
